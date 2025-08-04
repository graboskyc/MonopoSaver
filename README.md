# Monopo Saver

## Background
This is a simple website that will save track your Monopoly game details so you can restart later.

Each time you save, you are given a new immutable ID and link so you can send it to the friends you are playing with to insure there's no cheating going on.

Right now it stores the [Ghostbuster's Monopoly](https://hasbrogaming.hasbro.com/en-us/product/monopoly-game-ghostbusters-edition-for-kids-8-and-up:0CBDEDEA-AF56-46D5-8C0C-63E4428E64D2) and [New Monopoly](https://hasbrogaming.hasbro.com/en-us/product/monopoly-game:7EABAF97-5056-9047-F577-8F4663C79E75) and [Catopoly](https://www.amazon.com/Late-for-the-Sky-Cat-Opoly/dp/B0000663R6). It is written to support multiple Monopoly board types, I just need to do data entry on those in the `Board.cs` file.

It is offered as a service free [here](https://monoposaver.grabosky.net/).

Alternately to run yourself, copy the `sample.env` to `.env` and put your MongoDB cluster connection string in it. Then launch the docker container via `./build.sh`

## Tech Stack
* Single Page App written in Blazor
* Database is MongoDB Atlas

## Screenshots

![](Screenshots/ss01.png)
![](Screenshots/ss02.png)
![](Screenshots/ss03.png)
