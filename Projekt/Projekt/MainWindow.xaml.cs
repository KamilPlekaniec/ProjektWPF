using Projekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projekt
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LogowanieBTN_Click(object sender, RoutedEventArgs e)
        {
            Window2 wnd2 = new Window2();
            wnd2.Show();
        }

        private void RejestracjaBTN_Click(object sender, RoutedEventArgs e)
        {
            Window1 wnd1 = new Window1();
            wnd1.Show();
        }
    }
}
/* Zamlowa lista
 * <ListView ItemsSource="{Binding Students}" Grid.Row="3" Grid.Column="1" Width="200" Margin="-50 0 0 0">
            <ListView.View>
                <GridView>
                    <GridViewColumn Header="Name" DisplayMemberBinding="{Binding Name}" Width="60"/>
                    <GridViewColumn  Header="Age" DisplayMemberBinding="{Binding Age}" Width="60"/>
                    <GridViewColumn  Header="Joining Date" DisplayMemberBinding="{Binding JoiningDate, Converter={StaticResource MyConverter}}" Width="80" />
                </GridView>
            </ListView.View>
        </ListView>
*/

// kod zamlowy 

/*
   <Grid.RowDefinitions>
        <RowDefinition Height="Auto"/>
        <RowDefinition Height="Auto"/>  
        <RowDefinition Height="Auto"/>
        <RowDefinition Height="*"/>
        <RowDefinition Height="*"/>
    </Grid.RowDefinitions>
    <Grid.ColumnDefinitions>
        <ColumnDefinition Width="Auto"/>
        <ColumnDefinition Width="*"/>
    </Grid.ColumnDefinitions>
    <TextBlock Grid.Row="0" Grid.Column="0" Text="Name" HorizontalAlignment="Center"/>
    <TextBox Grid.Row="0" Grid.Column="1" Width="100" HorizontalAlignment="Center" Text="{Binding Student.Name, Mode=TwoWay}"/>
    <TextBlock Grid.Row="1" Grid.Column="0" Text="Age" HorizontalAlignment="Center"/>
    <TextBox Grid.Row="1" Grid.Column="1" Width="100" HorizontalAlignment="Center" Text="{Binding Student.Age, Mode=TwoWay}"/>
    <Button Content="Potwierdź" Command="{Binding SubmitCommand}" HorizontalAlignment="Right" Grid.Row="2" Grid.Column="0"/>
    <Button x:Name="btnReg" Content="Zarejestruj" Grid.Row="3" Grid.Column="1" Width="50" Height="20" Margin="200,60,20,20" FontSize="8" FontWeight="Bold" Click="BtnReg_Click" />

    */