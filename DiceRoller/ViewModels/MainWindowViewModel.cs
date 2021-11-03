using DiceRoller.Logic;
using DiceRoller.Translations.Resources;
using ReactiveUI;
using System;
using System.Globalization;
using System.Reactive;
using System.Threading;

namespace DiceRoller.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly Roll _roll; 

        public MainWindowViewModel()
        {
            SwitchLanguageCommand = ReactiveCommand.Create(SwitchLanguage);
            RollDiceCommand = ReactiveCommand.Create<string>(RollDice);

            _roll = new Roll();
        }

        private void RollDice(string obj)
        {
            if (int.TryParse(obj, out int result))
            {
                RollResult = _roll.RollDice(result).ToString();
                this.RaisePropertyChanged(nameof(RollResult));
            }
        }

        private void SwitchLanguage()
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == "pl-PL")
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            else if (Thread.CurrentThread.CurrentUICulture.Name == "en-US")
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("pl-PL");

            this.RaisePropertyChanged(nameof(D4DiceText));
            this.RaisePropertyChanged(nameof(D6DiceText));
            this.RaisePropertyChanged(nameof(D8DiceText));
            this.RaisePropertyChanged(nameof(D10DiceText));
            this.RaisePropertyChanged(nameof(D12DiceText));
            this.RaisePropertyChanged(nameof(D20DiceText));
            this.RaisePropertyChanged(nameof(D100DiceText));
            this.RaisePropertyChanged(nameof(RollButtonContent));
        }

        public string D4DiceText => Language.d4;
        public string D6DiceText => Language.d6;
        public string D8DiceText => Language.d8;
        public string D10DiceText => Language.d10;
        public string D12DiceText => Language.d12;
        public string D20DiceText => Language.d20;
        public string D100DiceText => Language.d100;
        public string RollButtonContent => Language.Roll;

        public string RollResult { get; set; }

        public ReactiveCommand<Unit, Unit> SwitchLanguageCommand { get; }

        public ReactiveCommand<string, Unit> RollDiceCommand { get; }
    }
}
