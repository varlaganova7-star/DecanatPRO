using DecanatPRO.BusinessLogic;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DecanatPRO.WinFormsView
{
    public partial class ChartForm : Form
    {
        public ChartForm(Logic logic)
        {
            InitializeComponent();

            var distribution = logic.GetSpecialityDistribution();

            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add("Распределение студентов по специальностям");

            Series series = new Series
            {
                Name = "Студенты",
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Column
            };

            foreach (var item in distribution)
            {
                series.Points.AddXY(item.Key, item.Value);
            }

            chart1.Series.Add(series);
        }
    }
}