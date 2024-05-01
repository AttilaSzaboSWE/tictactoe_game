//Dardos Dániel csinálta
private void exit(object sender, RoutedEventArgs e) //Kilépés gomb
{
    if (MessageBox.Show("Biztos ki akarsz lépni?", "Megerősítés", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
    {
        Application.Current.Shutdown();
    }
}

private void button1_Click(object sender, RoutedEventArgs e)
{
    if (checking == false)
    {
        button1.Content = "X";
        checking = true;
    }
    else
    {
        button1.Content = "O";
        checking = false;
    }
    button1.IsEnabled = false;
    score_check();
    score_table();
}


private void button2_Click(object sender, RoutedEventArgs e)
{
    if (checking == false)
    {
        button2.Content = "X";
        checking = true;
    }
    else
    {
        button2.Content = "O";
        checking = false;
    }
    button2.IsEnabled = false;
    score_check();
    score_table();
}

private void button3_Click(object sender, RoutedEventArgs e)
{
    if (checking == false)
    {
        button3.Content = "X";
        checking = true;
    }
    else
    {
        button3.Content = "O";
        checking = false;
    }
    button3.IsEnabled = false;
    score_check();
    score_table();
}

private void button5_Click(object sender, RoutedEventArgs e)
{
    if (checking == false)
    {
        button5.Content = "X";
        checking = true;
    }
    else
    {
        button5.Content = "O";
        checking = false;
    }
    button5.IsEnabled = false;
    score_check();
    score_table();

}

private void button4_Click(object sender, RoutedEventArgs e)
{
    if (checking == false)
    {
        button4.Content = "X";
        checking = true;
    }
    else
    {
        button4.Content = "O";
        checking = false;
    }
    button4.IsEnabled = false;
    score_check();
    score_table();
}

private void button6_Click(object sender, RoutedEventArgs e)
{
    if (checking == false)
    {
        button6.Content = "X";
        checking = true;
    }
    else
    {
        button6.Content = "O";
        checking = false;
    }
    button6.IsEnabled = false;
    score_check();
    score_table();
}

private void button7_Click(object sender, RoutedEventArgs e)
{
    if (checking == false)
    {
        button7.Content = "X";
        checking = true;
    }
    else
    {
        button7.Content = "O";
        checking = false;
    }
    button7.IsEnabled = false;
    score_check();
    score_table();
}

private void button8_Click(object sender, RoutedEventArgs e)
{
    if (checking == false)
    {
        button8.Content = "X";
        checking = true;
    }
    else
    {
        button8.Content = "O";
        checking = false;
    }
    button8.IsEnabled = false;
    score_check();
    score_table();
}

private void button9_Click(object sender, RoutedEventArgs e)
{
    if (checking == false)
    {
        button9.Content = "X";
        checking = true;
    }
    else
    {
        button9.Content = "O";
        checking = false;
    }
    button9.IsEnabled = false;
    score_check();
    score_table();
}
//Dardos Dani csinálta
private void kovfordulo_Click_1(object sender, RoutedEventArgs e) //A kövi forduló gombhoz, resetáljuk a gombokat.
{
    List<Button> buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
    
    foreach (Button x in buttons)
    {
        x.IsEnabled = true;
        x.Content = "";
    }
    
}

private void Ujgame_Click(object sender, RoutedEventArgs e) //Az új játéknál a teljes eredménytáblát is reseteljük.
{
    List<Button> buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

    foreach (Button x in buttons)
    {
        x.IsEnabled = true;
        x.Content = "";
    }
    player_eredmenyek[0] = 0;
    player_eredmenyek[1] = 0;
    score_table();
}