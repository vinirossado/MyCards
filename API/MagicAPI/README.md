# MyCards
Projeto para exibir todas as cartas de MTG da minha coleção

## Build the docker image
```sh
docker build --rm . -t beam-of-light/magic-api
```

## Running the container
```sh
docker run --name magic-api -p 80:80 -d beam-of-light/magic-api
```

Go to https://localhost/swagger/index.html