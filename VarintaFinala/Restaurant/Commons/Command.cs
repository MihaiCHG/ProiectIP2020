﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Command
    {
        private List<Produs> _command;
        private int nrMasa;
        private double pret;
        public Command(List<Produs> listaProduse)
        {
            _command = listaProduse;
        }
        public double PretComanda
        {
            get => pret;
            set => pret = value;
        }
        public int NrMasa
        {
            get => nrMasa;
            set => nrMasa = value;
        }
        public List<Produs> CommandList
        {
            get => _command;
        }
        public void addProduct(Produs p)
        {
            _command.Add(p);
        }
    }
}
