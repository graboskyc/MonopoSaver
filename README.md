# Monopo Saver

## Background
This is a simple website that will save track your Monopoly game details so you can restart later.

Each time you save, you are given a new immutable ID and link so you can send it to the friends you are playing with to insure there's no cheating going on.

Right now it stores the [Ghostbuster's Monopoly](https://www.amazon.com/Hasbro-Monopoly-Game-Ghostbusters-Board/dp/B0844BKZDG/ref=sr_1_4?crid=J9B6C04FIJ7A&keywords=ghostbusters+monopoly&qid=1641222097&sprefix=ghostbusters+mon%2Caps%2C110&sr=8-4) places. It is written to support multiple Monopoly board types, I just need to do data entry on those.

It is offered as a service free [here](https://monoposaver-faflr.mongodbstitch.com).

## Screenshots

![](Screenshots/ss01.png)

## Tech Stack
* Single Page App written in Blazor
* Database is MongoDB Atlas
* Backend is MongoDB Realm App Services