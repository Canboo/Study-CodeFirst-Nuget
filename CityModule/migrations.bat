chcp 65001

REM 更新實體類別
dotnet ef migrations add Add_City --context ApiContext

REM 更新資料庫（如果沒有資料庫，將會自動建立全新資料庫）
dotnet ef database update --context ApiContext