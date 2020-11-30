using System;

namespace Anketa
{
    public class Anketa
    {
        public string FIO(string fio)
        {
            int kol = 0;
            string[] slova = fio.Split(' ');
            if (slova.Length == 2 || slova.Length == 3)
            {
                for (int i = 0; i < slova.Length; i++)
                {
                    string bukva = Convert.ToString(slova[i][0]);
                    if (bukva == bukva.ToUpper())
                    {
                        kol++;
                    }
                }
            }
            else
            {
                return ("0");
            }
            if (kol == slova.Length)
            {
                return ("1");
            }
            else
            {
                return ("0");
            }
        }



        public string Data(string data)
        {
            int oshib = 0;
            string[] chisla = data.Split('.');
            for (int g = 0; g < chisla.Length; g++)
            {
                for (int i = 0; i < chisla[g].Length; i++)
                {
                    if (Convert.ToChar(chisla[g][i]) < 48 || 57 < Convert.ToChar(chisla[g][i]))
                    {
                        oshib++;
                    }
                }
            }
            if (oshib == 0)
            {
                if (Convert.ToInt32(chisla[0]) < 1 || Convert.ToInt32(chisla[0]) > 31)
                {
                    return ("0");
                }
                else if (Convert.ToInt32(chisla[1]) < 1 || Convert.ToInt32(chisla[1]) > 12)
                {
                    return ("0");
                }
                else if (Convert.ToInt32(chisla[2]) < 1 || Convert.ToInt32(chisla[2]) > 2021)
                {
                    return ("0");
                }
                else
                {
                    return ("1");
                }
            }
            else
            {
                return ("0");
            }
        }



        public string Tel(string tel)
        {
            int kol = 0;
            string cifri = "0123456789";
            if ("+".CompareTo(Convert.ToString(tel[0])) == 0)
            {
                for (int i = 1; i < tel.Length; i++)
                {
                    for (int j = 0; j < cifri.Length; j++)
                    {
                        if (tel[i] == cifri[j])
                        {
                            kol++;
                        }
                    }
                }
                if (kol == 11)
                {
                    return ("1");
                }
                else
                {
                    return ("0");
                }
            }
            else
            {
                for (int i = 0; i < tel.Length; i++)
                {
                    for (int j = 0; j < cifri.Length; j++)
                    {
                        if (tel[i] == cifri[j])
                        {
                            kol++;
                        }
                    }
                }
                if (kol == 11)
                {
                    return ("1");
                }
                else
                {
                    return ("0");
                }
            }
        }



        public string Mail(string mail)
        {
            string[] chast = mail.Split('@');
            string[] toch = chast[chast.Length - 1].Split('.');
            if (chast.Length != 2)
            {
                return ("0");
            }
            else if (chast[0].Length < 1 || chast[1].Length < 1)
            {
                return ("0");
            }
            else if (toch.Length != 2)
            {
                return ("0");
            }
            else if (toch[0].Length < 1 || toch[1].Length < 1)
            {
                return ("0");
            }
            else
            {
                string prov="";
                for (int g = 0; g < chast.Length; g++)
                {
                    for (int i = 0; i < chast[g].Length; i++)
                    {
                        if (((Convert.ToChar(chast[g][i]) < 97 || 122 < Convert.ToChar(chast[g][i])) && (Convert.ToChar(chast[g][i]) < 48 || 57 < Convert.ToChar(chast[g][i]))) && chast[g][i] + "" != ".")
                        {
                            return ("0");
                        }
                        else if (i == 0 && chast[g][i] + "" == ".")
                        {
                            return ("0");
                        }
                        else if (i == chast[g].Length - 1 && chast[g][i] + "" == ".")
                        {
                            return ("0");
                        }
                        else
                        {
                            prov = prov + chast[g][i];
                        }
                    }
                    if(g==0) prov = prov + "@";
                }
                if (prov==mail)
                {
                    return ("1");
                }
                else return ("0");
            }
        }
    }
}