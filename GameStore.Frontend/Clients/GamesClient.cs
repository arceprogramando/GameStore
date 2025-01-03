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

    private readonly Genre[] genres = new GenresClient().GetGenres();
    
    public GameSummary[] GetGames()=> [.. games];

    public void AddGame(GameDetails game)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(game.GenreId);
        var genre = genres.Single(genre => genre.Id == int.Parse(game.GenreId));
        var GameSummary = new GameSummary
        {
            Id = games.Count + 1,
            Name = game.Name,
            Genre = genre.Name,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate,
        };
    }
}
