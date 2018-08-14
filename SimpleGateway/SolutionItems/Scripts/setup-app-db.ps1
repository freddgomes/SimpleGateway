$sw = [Diagnostics.Stopwatch]::StartNew()

$ScriptPath = Split-Path $MyInvocation.InvocationName

# Criação dos Databases
& "$ScriptPath\run-sql.ps1" -server .\SQLEXPRESS -dbname master -file "$ScriptPath\CreateDatabase.sql" -go

# Criação dos Schemas
& "$ScriptPath\run-sql.ps1" -server .\SQLEXPRESS -dbname SimpleGatewayDb -file "$ScriptPath\Transaction.sql" -go -iguse
& "$ScriptPath\run-sql.ps1" -server .\SQLEXPRESS -dbname SimpleGatewayDb -file "$ScriptPath\Log.sql" -go -iguse
#

$sw.Stop()

Write-Host
Write-Host "Tempo de execução: " $sw.Elapsed