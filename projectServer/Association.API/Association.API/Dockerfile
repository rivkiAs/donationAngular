FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# מעתיק את כל התוכן של התיקייה לתוך ה-Docker
COPY . .

# הרצת פקודות ללא ציון שם קובץ ספציפי (זה ימצא את ה-csproj לבד)
RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# הגדרת פורט חובה עבור Render
ENV ASPNETCORE_URLS=http://+:10000
EXPOSE 10000

# הרצת השרת (ודאי ששם ה-DLL תואם לשם הפרויקט שלך)
ENTRYPOINT ["dotnet", "Association.API.dll"]
