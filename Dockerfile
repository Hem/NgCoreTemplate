FROM microsoft/aspnetcore-build:2.0 as build-env

WORKDIR /src

# copy csproj files
COPY *.sln ./
COPY ./Repository.Contracts/*.csproj ./Repository.Contracts/
COPY ./Repository/*.csproj ./Repository/
COPY ./Repository.UnitTest/*.csproj ./Repository.UnitTest/
COPY ./Web/*.csproj ./Web/
# issue .net restore command
RUN dotnet restore

# command to list all files in all directories
# RUN ls -d **/*

# issue npm install command
WORKDIR /src/Web 
COPY ./Web/package.json .
RUN npm install

RUN ls -d **/*

# 
WORKDIR /src
COPY . .

# RUN dotnet build --configuration Debug

WORKDIR /src/Web
RUN rm -rf node_modules

RUN dotnet publish --output /app/ --configuration Release
# build our code


FROM microsoft/aspnetcore
WORKDIR /app
COPY --from=build-env /app .
ENTRYPOINT ["dotnet", "Web.dll"]

# docker build -t  hem/ngcoretemplate-build .
# docker run -it -p 5000:80 hem/ngcoretemplate-build