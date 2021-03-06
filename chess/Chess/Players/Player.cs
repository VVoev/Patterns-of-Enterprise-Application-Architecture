﻿using Common;
using Figures;
using Players.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Players
{
    public class Player : IPlayer
    {
        private readonly ICollection<IFigure> figures;


        public ChessColor Color { get; private set; }

        public string Name { get; private set; }

        public Player(string name,ChessColor color)
        {
            this.Name = name;
            this.figures = new List<IFigure>();
            this.Color = Color;
        }

        public void AddFigure(IFigure figure)
        {
            OBjectValidator.CheckIfOBjectIsNull(figure,GlobalErrorMessages.NULLFIGUREMESAGE);
            CheckIfFigureExist(figure);
            this.figures.Add(figure);
        }

        public void RemoveFigure(IFigure figure)
        {
            OBjectValidator.CheckIfOBjectIsNull(figure, GlobalErrorMessages.NULLFIGUREMESAGE);
            CheckIFFigureDoesNotExist(figure);
            this.figures.Remove(figure);

        }

        private void CheckIfFigureExist(IFigure figure)
        {
            if (this.figures.Contains(figure))
            {
                throw new InvalidOperationException(GlobalErrorMessages.PLAYERALREADYOWN_FIGURE);
            }
        }


        private void CheckIFFigureDoesNotExist(IFigure figure)
        {
            if (!this.figures.Contains(figure))
            {
                throw new InvalidOperationException(GlobalErrorMessages.PLAYERNOTOWN_FIGURE);
            }
        }
    }
}
