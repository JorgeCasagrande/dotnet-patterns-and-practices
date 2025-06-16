using System;
using System.Collections.Generic;

// Example of the Command pattern in .NET
// Remote control scenario: commands to turn a light on/off and undo

namespace CommandPatternExample
{
    // Command interface
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    // Receiver: Light
    public class Light
    {
        public void On() => Console.WriteLine("Light is ON");
        public void Off() => Console.WriteLine("Light is OFF");
    }

    // Concrete Command: Turn light on
    public class LightOnCommand : ICommand
    {
        private readonly Light _light;
        public LightOnCommand(Light light) => _light = light;
        public void Execute() => _light.On();
        public void Undo() => _light.Off();
    }

    // Concrete Command: Turn light off
    public class LightOffCommand : ICommand
    {
        private readonly Light _light;
        public LightOffCommand(Light light) => _light = light;
        public void Execute() => _light.Off();
        public void Undo() => _light.On();
    }

    // Invoker: Remote control
    public class RemoteControl
    {
        private ICommand _command;
        private readonly Stack<ICommand> _history = new();
        public void SetCommand(ICommand command) => _command = command;
        public void PressButton()
        {
            _command.Execute();
            _history.Push(_command);
        }
        public void PressUndo()
        {
            if (_history.Count > 0)
                _history.Pop().Undo();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var light = new Light();
            var lightOn = new LightOnCommand(light);
            var lightOff = new LightOffCommand(light);
            var remote = new RemoteControl();

            // Turn the light on
            remote.SetCommand(lightOn);
            remote.PressButton();

            // Turn the light off
            remote.SetCommand(lightOff);
            remote.PressButton();

            // Undo last command (turns light on)
            remote.PressUndo();
        }
    }
}
