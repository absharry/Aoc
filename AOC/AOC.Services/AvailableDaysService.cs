using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using AOC.Domain.Models;
using Newtonsoft.Json;
using System.Linq;

namespace AOC.Services
{
    public class AvailableDaysService : IAvailableDaysService
    {
        private List<AvailableYear> AvailableYears { get; set; }

        public AvailableDaysService()
        {
            
        }

        public int GetAvailableYears()
        {
            var coordinates = new List<Coordinates>()
            {
                new Coordinates(252, 125),
                 new Coordinates(128, 333),
                 new Coordinates(89, 324),
                 new Coordinates(141, 171),
                 new Coordinates(266, 338),
                 new Coordinates(117, 175),
                 new Coordinates(160, 236),
                 new Coordinates(234, 202),
                 new Coordinates(165, 192),
                 new Coordinates(204, 232),
                 new Coordinates(83, 192),
                 new Coordinates(229, 178),
                 new Coordinates(333, 57),
                 new Coordinates(70, 243),
                 new Coordinates(108, 350),
                 new Coordinates(161, 63),
                 new Coordinates(213, 277),
                 new Coordinates(87, 299),
                 new Coordinates(163, 68),
                 new Coordinates(135, 312),
                 new Coordinates(290, 87),
                 new Coordinates(73, 246),
                 new Coordinates(283, 146),
                 new Coordinates(80, 357),
                 new Coordinates(66, 312),
                 new Coordinates(159, 214),
                 new Coordinates(221, 158),
                 new Coordinates(175, 54),
                 new Coordinates(298, 342),
                 new Coordinates(348, 162),
                 new Coordinates(249, 90),
                 new Coordinates(189, 322),
                 new Coordinates(311, 181),
                 new Coordinates(194, 244),
                 new Coordinates(53, 295),
                 new Coordinates(80, 301),
                 new Coordinates(262, 332),
                 new Coordinates(268, 180),
                 new Coordinates(139, 287),
                 new Coordinates(115, 53),
                 new Coordinates(163, 146),
                 new Coordinates(220, 268),
                 new Coordinates(79, 85),
                 new Coordinates(95, 112),
                 new Coordinates(349, 296),
                 new Coordinates(179, 274),
                 new Coordinates(113, 132),
                 new Coordinates(158, 264),
                 new Coordinates(316, 175),
                 new Coordinates(268, 215)
            };
            var height = coordinates.Max(x => x.Y);
            var width = coordinates.Max(x => x.X);

            var topLeft = new Coordinates(0, 0);
            var topRight = new Coordinates(width, 0);
            var bottomLeft = new Coordinates(0, height);
            var bottomRight = new Coordinates(width, height);

            var closestPoints = new Dictionary<Coordinates, Guid>();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Guid closestCoordId = Guid.Empty;
                    var closestDistance = width + height;

                    foreach (var coord in coordinates)
                    {
                        var distance = Math.Abs(j - coord.X) + Math.Abs(i - coord.Y);

                        if(distance < closestDistance)
                        {
                            closestDistance = distance;
                            closestCoordId = coord.Id;
                        } else if(distance == closestDistance)
                        {
                            closestCoordId = Guid.Empty;
                            break;
                        }
                    }

                    closestPoints.Add(new Coordinates(j, i), closestCoordId);
                }
            }

            var areas = coordinates.Where(x => x.X != 0 && x.X != width && x.Y != 0 && x.Y != height).Select(x => new
            {
                Coordinate = x.Id,
                Area = closestPoints.Count(y => y.Value == x.Id)
            }).OrderByDescending(x => x.Area);

            return areas.First().Area;
        }
    }

    public class Coordinates
    {

        public Coordinates(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        public int X { get; set; }

        public int Y { get; set; }
    }
}
