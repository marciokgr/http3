try {
    $response = Invoke-WebRequest -Uri 'https://localhost:5001/' -Method GET -ContentType 'application/json' -Protocol 'http3'
    $data = $response.Content | ConvertFrom-Json
    Write-Output $data
}
catch {
    Write-Error "Ocorreu um erro: $_"
}