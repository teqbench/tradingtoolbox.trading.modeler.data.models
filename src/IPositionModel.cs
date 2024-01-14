using System;
namespace TradingToolbox.Trading.Modeler.Data.Models
{
    interface IPositionModel
    {
        /// <summary>
        /// Gets or sets the name of the position model.
        /// </summary>
        /// <value>
        /// The name of the position model.
        /// </value>
        string? Name { get; set; }

        /// <summary>
        /// Gets or sets the initial position value.
        /// </summary>
        /// <value>
        /// The initial position value.
        /// </value>
        Decimal InitialValue { get; set; }

        /// <summary>
        /// Gets or sets the price per share.
        /// </summary>
        /// <value>
        /// The price per share.
        /// </value>
        Decimal PricePerShare { get; set; }

        /// <summary>
        /// Gets or sets the average number of positions per day.
        /// </summary>
        /// <value>
        /// The average number of positions per day.
        /// </value>
        Byte AverageNumberOfPositionsPerDay { get; set; }

        /// <summary>
        /// Gets or sets the average number of lots per position.
        /// </summary>
        /// <value>
        /// The average number of lots per position.
        /// </value>
        Byte AverageNumberOfLotsPerPosition { get; set; }

        /// <summary>
        /// Gets or sets the average number of trading days per week.
        /// </summary>
        /// <value>
        /// The average number of trading days per week.
        /// </value>
        Byte AverageNumberOfTradingDaysPerWeek { get; set; }

        /// <summary>
        /// Gets or sets the estimated success rate.
        /// </summary>
        /// <value>
        /// The estimated success rate.
        /// </value>
        Decimal EstimatedSuccessRate { get; set; }

        /// <summary>
        /// Gets or sets the target gain.
        /// </summary>
        /// <value>
        /// The target gain.
        /// </value>
        Decimal TargetGain { get; set; }

        /// <summary>
        /// Gets or sets the federal tax rate.
        /// </summary>
        /// <value>
        /// The federal tax rate.
        /// </value>
        Decimal FederalTaxRate { get; set; }

        /// <summary>
        /// Gets or sets the state tax rate.
        /// </summary>
        /// <value>
        /// The state tax rate.
        /// </value>
        Decimal StateTaxRate { get; set; }

        /// <summary>
        /// Gets or sets the expenses.
        /// </summary>
        /// <value>
        /// The expenses.
        /// </value>
        Decimal Expenses { get; set; }

        /// <summary>
        /// Gets or sets the estimated fee per transaction.
        /// </summary>
        /// <value>
        /// The estimated fee per transaction.
        /// </value>
        Decimal EstimatedFeePerTransaction { get; set; }

        /// <summary>
        /// Gets or sets the list position.
        /// </summary>
        /// <value>
        /// The list position.
        /// </value>
        long ListPosition { get; set; }
    }
}

