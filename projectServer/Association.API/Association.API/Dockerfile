FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# העתקת כל הקבצים לתוך ה-Container
COPY . .

# פקודות בנייה שלא דורשות שם קובץ ספציפי - זה ימצא את ה-csproj לבד
RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# הגדרת פורט חובה עבור Render
ENV ASPNETCORE_URLS=http://+:10000
EXPOSE 10000

# הרצת ה-DLL (ודאי ששם הקובץ תואם לשם הפרויקט שלך)
ENTRYPOINT ["dotnet", "Association.API.dll"]
