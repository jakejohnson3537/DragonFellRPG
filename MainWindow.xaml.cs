﻿using System.Windows;
using System.Windows.Documents;
using MahApps.Metro.Controls;
using Engine.ViewModels;
using Engine.EventArgs;

namespace RPGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        

        private readonly GameSession _gameSession;
        public MainWindow()
        {
            InitializeComponent();
             
            _gameSession = new GameSession();

            _gameSession.OnMessageRaised += OnGameMessageRaised;


            DataContext = _gameSession;
        }

        private void OnClick_MoveNorth(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveNorth();
        }

        private void OnClick_MoveWest(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveWest();
        }

        private void OnClick_MoveEast(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveEast();
        }

        private void OnClick_MoveSouth(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveSouth();
        }

        private void OnClick_AttackMonster(object sender, RoutedEventArgs e)
        {
            _gameSession.AttackCurrentMonster();
        }

        private void OnGameMessageRaised(object sender, GameMessageEventArgs e)
        {
            GameMessages.Document.Blocks.Add(new Paragraph(new Run(e.Message)));
            GameMessages.ScrollToEnd();
        }

        private void OnClick_DisplayTradeScreen(object sender, RoutedEventArgs e)
        {
            TradeScreen tradeWindow = new TradeScreen();
            tradeWindow.Owner = this;
            tradeWindow.DataContext = _gameSession;
            tradeWindow.ShowDialog();
        }

    }
}
