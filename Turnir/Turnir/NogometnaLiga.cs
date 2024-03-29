﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnir
{
    internal class NogometnaLiga
    {
        //izdelaj turnir
        Ekipa[] liga = new Ekipa[10];
        int x = 0;int y = 1; //kar rabim za round robin
        int[] gor = {2,3,4,5 };
        int[] dol = { 9, 8, 7, 6 };
        int[,] pari = new int[10, 10];
        //pari[2,4]=7 pomeni, da se ekipa 2 in ekipa 4 srečata v 7. kolu
        public void NapolniPare(int kolo)
        {
            pari[x, y] = kolo;
            for (int k = 0; k < 4; k++)
            {
                pari[gor[k], dol[k]] = kolo;
            }
            //zavrti za naslednje kolo
            int temp = y; //začasno shranim y
            y = dol[0];
            dol[0] = dol[1]; dol[1] = dol[2]; dol[2] = dol[3];
            dol[3] = gor[3]; gor[3] = gor[2]; gor[2] = gor[1]; gor[1] = gor[0];
            gor[0] = temp;
        }
        public void IzdelajTurnir()
        {
            for (int kolo = 1; kolo <= 9; kolo++)
                NapolniPare(kolo);
        }
        public NogometnaLiga()
        {
            liga[0] = new Ekipa("Slovenija");
            liga[1] = new Ekipa("Italija  ");
            liga[2] = new Ekipa("Irska    ");
            liga[3] = new Ekipa("Anglija  ");
            liga[4] = new Ekipa("Nemčija  ");
            liga[5] = new Ekipa("Poljska  ");
            liga[6] = new Ekipa("Švica    ");
            liga[7] = new Ekipa("Češka    ");
            liga[8] = new Ekipa("Belgija  ");
            liga[9] = new Ekipa("Švedska  ");
            IzdelajTurnir();
        }
        //testna metoda, da vidimo cel trunir
        public void IzpisTurnirja()
        {
            for (int kolo = 1; kolo <= 9; kolo++)
            {
                Console.WriteLine(kolo+". kolo");
                for (int k = 0; k < 10; k++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (pari[k, j] == kolo)
                        {
                            //ekipa k in j se srečata v tem kolu
                            Console.WriteLine(liga[k].Ime+" : " + liga[j].Ime);
                        }
                    }
                }
            }
            
        }
        public void VnesiKolo(int kolo)
        {
            //ponovi za vse pare tega kola
            // rač izpiše prvi par kola Slovenija:Italija
            //uporabnik vnese rezultat v obliki 2:3
            Console.WriteLine(kolo + ". kolo");
            for (int k = 0; k < 10; k++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (pari[k, j] == kolo)
                    {
                        //ekipa k in j se srečata v tem kolu
                        Console.WriteLine(liga[k].Ime + " : " + liga[j].Ime);
                        //vnesi rezultat v obliki 2:3
                        string r = Console.ReadLine();//"2:3"
                        string[] vsi=r.Split(':');//vsi[0] so goli prve ekipe
                        int goli1 = int.Parse(vsi[0]);
                        int goli2 = int.Parse(vsi[1]);
                        liga[k].VpisRezultata(goli1, goli2);
                        liga[j].VpisRezultata(goli2, goli1);
                    }
                }
            }
            //izpiši vse ekipe
            //najprej uredi tabelo
            Ekipa[] urejena = new Ekipa[10];
            //urejena = liga; NIKOLI NE DELAJ TEGA
            for (int k = 0; k < 10; k++)
            {
                urejena[k] = liga[k];
            }
            //uredi 
            for (int k = 0; k < 10; k++)
            {
                //izberi najboljšo ekipo od k do konca tabele
                Ekipa max = urejena[k];
                int maxindeks = k;
                for (int j = k + 1; j < 10; j++)
                {
                    if (urejena[j].BoljšaEkipa(max)) //namesto >
                    {
                        max = urejena[j];
                        maxindeks = j;
                    }
                }
                //zamenjaj jo s prvo od preostanka
                Ekipa temp = urejena[k];
                urejena[k] = urejena[maxindeks];
                urejena[maxindeks] = temp;
            }
            Console.WriteLine("Rezultati");
            Console.WriteLine("*************************");
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine( urejena[k].Izpis());
            }
            Console.WriteLine("*************************");
        }
        //dodatno
        //sortiraj tabelo liga v smislu BoljšaEkipa, spet izpiši
    }
}
