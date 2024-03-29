﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fruits_Web_Game.Controllers
{
    public class HomeController : Controller
    {
        static int rowsCount = 3;
        static int colsCount = 9;
        static string[,] fruits = GenerateRandomFruits();
        private static string[,] GenerateRandomFruits()
        {
            var rand = new Random();
            fruits = new string[rowsCount, colsCount];
            for (int row = 0; row < rowsCount; row++)
            {
                for (int col = 0; col < colsCount; col++)
                {
                    var r = rand.Next(9);
                    if (r < 2) fruits[row, col] = "apple";
                    else if (r < 4) fruits[row, col] = "banana";
                    else if (r < 6) fruits[row, col] = "kiwi";
                    else if (r < 8) fruits[row, col] = "orange";
                    else fruits[row, col] = "dynamite";
                }
            }
            return fruits;
        }
        static int score = 0;
        static bool gameOver = false;

        public ActionResult Index()
        {
            ViewBag.rowsCount = rowsCount;
            ViewBag.colsCount = colsCount;
            ViewBag.fruits = fruits;
            ViewBag.score = score;
            ViewBag.gameOver = gameOver;
            return View();
        }

        public ActionResult Reset() 
        {
            score = 0;
            gameOver = false;
            fruits = GenerateRandomFruits();
            return Redirect("Index");
        }

        public ActionResult FireTop(int position)
        {
            return Fire(position, 0, 1);
        }

        public ActionResult FireBottom(int position)
        {
            return Fire(position, rowsCount - 1, -1);
        }

        private ActionResult Fire(int position, int startRow, int step)
        {
            var col = position * (colsCount - 1) / 100;
            var row = startRow;
            while (row >= 0 && row < rowsCount)
            {
                var fruit = fruits[row, col];
                if (fruit == "apple" || fruit == "banana" || fruit == "orange" || fruit == "kiwi")
                {
                    score++;
                    fruits[row, col] = "empty";
                    break;
                }
                else if (fruit == "dynamite")
                {
                    gameOver = true;
                    break;
                }
                row = row + step;
            }
            return RedirectToAction("Index");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}