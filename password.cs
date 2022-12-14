 private void btn_sifre_uret_Click(object sender, EventArgs e)
        {
            passwordTxt.Text = "";
            string myPassword = "";
            int rnd = 0;

            Random rnd_kharf = new Random();
            Random rnd_bharf = new Random();
            Random rnd_rakam = new Random();

            for (int i = 0; i < Convert.ToInt16(txt_b_harf_sayisi.Text); i++)
            {
                rnd = rnd_bharf.Next(0, txt_buyuk_harfler.Text.Length - 1);
                passwordTxt.Text += txt_buyuk_harfler.Text[rnd];
            }
            for (int i = 0; i < Convert.ToInt16(txt_k_harf_sayisi.Text); i++)
            {
                rnd = rnd_kharf.Next(0, txt_kucuk_harfler.Text.Length - 1);
                passwordTxt.Text += txt_kucuk_harfler.Text[rnd];
            }
            for (int i = 0; i < Convert.ToInt16(txt_rakam_sayisi.Text); i++)
            {
                rnd = rnd_rakam.Next(0, txt_rakamlar.Text.Length - 1);
                passwordTxt.Text += txt_rakamlar.Text[rnd];
            }

            Random rnd_karistir = new Random();
            myPassword = passwordTxt.Text;
            passwordTxt.Text = new string(myPassword.ToCharArray().OrderBy(s => (rnd_karistir.Next(2) % 2) == 0).ToArray());

        }