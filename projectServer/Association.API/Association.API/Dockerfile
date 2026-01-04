FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# העתקת כל הקבצים לתוך ה-Docker
COPY . .

# הרצת Restore ו-Publish לכל פרויקט שנמצא בתיקייה (חוסך בעיות של שמות קבצים)
RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# הגדרת פורט חובה עבור Render
ENV ASPNETCORE_URLS=http://+:10000
EXPOSE 10000

# שימי לב: ודאי שהשם כאן תואם לשם ה-DLL שנוצר (בדרך כלל שם הפרויקט)
ENTRYPOINT ["dotnet", "Association.API.dll"]
