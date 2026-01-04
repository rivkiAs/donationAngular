# השתמש ב-SDK 6.0 לבנייה
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# העתקת כל הקבצים
COPY . .

# הרצת ה-Restore וה-Publish ללא ציון שם קובץ ספציפי
RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish

# השתמש ב-Runtime 6.0 להרצה
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# הגדרת פורט חובה עבור Render
ENV ASPNETCORE_URLS=http://+:10000
EXPOSE 10000

# הרצת האפליקציה (ודאי ששם ה-DLL תואם לשם הפרויקט שלך)
ENTRYPOINT ["dotnet", "Association.API.dll"]
