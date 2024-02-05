global using System;

public class Program {

    public static void Main(string[] args) { 

        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/kryptera", (string text) => Encrypt.kryptering(text));
        app.MapGet("/avkryptera", (string text) => Decrypt.AvKryptering(text));


        app.Run(); 
    }
}