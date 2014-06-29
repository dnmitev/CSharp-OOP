using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class AdvancedHoldingPen : HoldingPen
    {
        protected override void ExecuteAddSupplementCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "PowerCatalyst":
                    {
                        string target = commandWords[2];
                        var targetUnit = this.GetUnit(target);
                        targetUnit.AddSupplement(new PowerCatalyst());
                        break;
                    }
                case "HealthCatalyst":
                    {
                        string target = commandWords[2];
                        var targetUnit = this.GetUnit(target);
                        targetUnit.AddSupplement(new HealthCatalyst());
                        break;
                    }
                case "AggressionCatalyst":
                    {
                        string target = commandWords[2];
                        var targetUnit = this.GetUnit(target);
                        targetUnit.AddSupplement(new AggressionCatalyst());
                        break;
                    }
            }
        }

        protected override void ExecuteInsertUnitCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "Tank":
                    var tank = new Tank(commandWords[2]);
                    this.InsertUnit(tank);
                    break;
                case "Marine":
                    var marineHuman = new Marine(commandWords[2]);
                    this.InsertUnit(marineHuman);
                    break;
                case "Parasite":
                    var parasite = new Parasite(commandWords[2]);
                    this.InsertUnit(parasite);
                    break;
                case "Queen":
                    var queen = new Queen(commandWords[2]);
                    this.InsertUnit(queen);
                    break;
            }

            base.ExecuteInsertUnitCommand(commandWords);
        }
    }
}
