fetch('https://localhost:5001/', {
method: 'GET',
headers: {
    'Accept': 'application/json',
    'Content-Type': 'application/json'
},
protocol: 'http3',
})
.then(response => {
    if (!response.ok) {
        throw new Error('Erro na internet');
    }
    return response.json();
})
.then(data => {
    console.log(data);
})
.catch(error => {
    console.error('Ocorreu um erro:', error);
});