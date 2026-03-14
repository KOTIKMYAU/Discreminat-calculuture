using System;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using System.IO;

namespace Gubby;

public partial class MainWindow : Window
{
    private double a = 0;
    private double b = 0;
    private double c = 0;
    private double D = 0;
    private double OneX = 0;
    private double TwoX = 0;
    private string No = "Нет корней";
    private const string FilePath = "C:\\Users\\User\\Documents\\text.txt";

    public MainWindow()
    {
        InitializeComponent();

        var answer = File.ReadAllText(FilePath);
        SendMessage.Text = answer;
    }
    private void TextBox_TextChanged(object? sender, TextChangedEventArgs e)
    {
        
    }
    
    private void TextBox_KeyDown(object? sender, KeyEventArgs e)
    {
        
        if (e.Key == Key.Enter)
        {
            a = double.Parse(A.Text);
            b = double.Parse(B.Text);
            c = double.Parse(C.Text);
            D = (b*b)-4*a*c;
            if (D >= 0)
            {
                OneX = (-b + (Math.Sqrt(D))) / (2 * a);
                TwoX = (-b - (Math.Sqrt(D))) / (2 * a);
            }
            
        }
        SaveMessage();
        
    }
    
    private void SaveMessage()
    {
        if (D >= 0)
        {
            SendMessage.Text = OneX.ToString();
            SendMessage1.Text = TwoX.ToString();
        }
        else
        {
            SendMessage.Text = No;
            SendMessage1.Text = No;
        }
    }
    private void Button_Click(object? sender, RoutedEventArgs e)
    {
            a = double.Parse(A.Text);
            b = double.Parse(B.Text);
            c = double.Parse(C.Text);
            D = (b*b)-4*a*c;
            OneX = (-b + (Math.Sqrt(D)))/(2*a);
            TwoX = (-b - (Math.Sqrt(D)))/(2*a);

        SaveMessage();
        
    }
    
}

