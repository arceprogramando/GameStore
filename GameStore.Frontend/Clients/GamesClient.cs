using System;
using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class GamesClient
{
    private readonly List<GameSummary> games =
    [
        new()
        {
            Id = 1,
            Name = "Street Fighter II",
            Genre = "Fighting",
            Price = 19.99M,
            ReleaseDate = new DateOnly(1992, 7, 15)
        },
        new()
        {
            Id = 2,
            Name = "Halo: Combat Evolved",
            Genre = "FPS",
            Price = 39.99M,
            ReleaseDate = new DateOnly(2001, 11, 15)
        },
        new()
        {
            Id = 3,
            Name = "The Legend of Zelda: Ocarina of Time",
            Genre = "Adventure",
            Price = 59.99M,
            ReleaseDate = new DateOnly(1998, 11, 21)
        },
        new()
        {
            Id = 4,
            Name = "Arce",
            Genre = "Helicopter",
            Price = 570.99M,
            ReleaseDate = new DateOnly(1998, 11, 21)
        }
    ];
    public GameSummary[] GetGames()=> [.. games];
}
