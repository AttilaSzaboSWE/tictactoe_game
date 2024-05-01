//Kiss Bálint csinálta
void score_check() //itt leellenőrizzük, hogy nyert-e már a felhasználó
{

    string[] list = new string[] { "X", "O" };

    
    for (int i = 0; i < list.Length; i++)
    {
        if (button1.Content == list[i] && button2.Content == list[i] && button3.Content == list[i])
        {
            MessageBox.Show($"A győztes a {i+1} játékos.", "Information", MessageBoxButton.OK);
            player_eredmenyek[i] += 1;
        }
        else if (button4.Content == list[i] && button5.Content == list[i] && button6.Content == list[i])
        {
            MessageBox.Show($"A győztes a {i+1} játékos.");
            player_eredmenyek[i] += 1;
        }
        else if (button7.Content == list[i] && button8.Content == list[i] && button9.Content == list[i])
        {
            MessageBox.Show($"A győztes a {i + 1} játékos.");
            player_eredmenyek[i] += 1;
        }
        else if (button1.Content == list[i] && button5.Content == list[i] && button7.Content == list[i])
        {
            MessageBox.Show($"A győztes a {i + 1} játékos.");
            player_eredmenyek[i] += 1;
        }
        else if (button2.Content == list[i] && button4.Content == list[i] && button8.Content == list[i])
        {
            MessageBox.Show($"A győztes a {i + 1} játékos.");
            player_eredmenyek[i] += 1;
        }
        else if (button3.Content == list[i] && button6.Content == list[i] && button9.Content == list[i])
        {
            MessageBox.Show($"A győztes a {i + 1} játékos.");
            player_eredmenyek[i] += 1;
        }
        else if (button1.Content == list[i] && button4.Content == list[i] && button9.Content == list[i])
        {
            MessageBox.Show($"A győztes a {i + 1} játékos.");
            player_eredmenyek[i] += 1;
        }
        else if (button3.Content == list[i] && button4.Content == list[i] && button7.Content == list[i])
        {
            MessageBox.Show($"A győztes a {i + 1} játékos.");
            player_eredmenyek[i] += 1;
        }
    }

}

        //Kiss Bálint csinálta
        void score_table() //Az eredmények kiírása
        {
            eslojatekos_count.Content = Convert.ToString(player_eredmenyek[0]);
            masodikjatekos_count.Content = Convert.ToString(player_eredmenyek[1]);
        }
    }    
}