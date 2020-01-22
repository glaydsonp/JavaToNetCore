# Comando para gerar CRUDs, Controllers e Rotas
dotnet aspnet-codegenerator controller -name CONTROLLER-NAME -async -api -m MODEL-NAME -dc CONTEXT-NAME -outDir DIRETÓRIO-CONTROLLERS

# Comando para gerar e atualizar Migrations
dotnet ef migrations add initical --context CONTEXT-NAME
dotnet ef database update


