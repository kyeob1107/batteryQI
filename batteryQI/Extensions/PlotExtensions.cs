using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using batteryQI.ViewModels;
using System.Windows;
using ScottPlot;

namespace batteryQI.Extensions
{
    public static class PlotExtensions
    {
        public static readonly DependencyProperty PlotDataProperty =
            DependencyProperty.RegisterAttached(
                                                "PlotData",
                                                typeof(object),
                                                typeof(PlotExtensions),
                                                new PropertyMetadata(null, OnPlotDataChanged)
                                                );

        public static void SetPlotData(DependencyObject element, object value)
        {
            element.SetValue(PlotDataProperty, value);
        }

        public static object GetPlotData(DependencyObject element)
        {
            return element.GetValue(PlotDataProperty);
        }

        private static void OnPlotDataChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is WpfPlot wpfPlot && e.NewValue is ChartViewModel chartViewModel)
            {
                wpfPlot.Plot.Clear();
                wpfPlot.Plot.AxisAuto();
                chartViewModel.ConfigureChart(wpfPlot.Plot);
                wpfPlot.Refresh();
            }
        }
    }

}
