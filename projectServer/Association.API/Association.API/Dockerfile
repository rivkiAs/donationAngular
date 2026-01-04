FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# העתקת כל הקבצים מהתיקייה ב-GitHub לתוך ה-Docker
COPY . .

# פקודת בנייה כללית שלא מחפשת קובץ ספציפי אלא בונה את מה שיש בתיקייה
RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# הגדרת פורט חובה עבור Render
ENV ASPNETCORE_URLS=http://+:10000
EXPOSE 10000

# שימי לב: ודאי ששם ה-DLL כאן תואם בדיוק לשם הפרויקט שלך
ENTRYPOINT ["dotnet", "Association.API.dll"]
