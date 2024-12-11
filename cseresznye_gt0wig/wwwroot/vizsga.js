async function loadData() {
    const apiUrl = 'https://www.whenisthenextmcufilm.com/api';
    var response = await fetch(apiUrl)
    const data = await response.json()
    console.log(data);
    var x = document.getElementById("time")
    x.innerHTML = `A következő filmig ${data.days_until}-nap van hátra`
}

loadData();

//Filmek töltése
fetch("api/movies").then(r => r.json()).then(o => {
    var tábla = document.getElementById("movies_table")
    console.log(o)

    for (var i = 0; i < o.length; i++) {
        var sor = document.createElement("tr")

        sor.innerHTML = 
            `
            <td>${o[i].movieId}</td>
            <td>${o[i].title}</td>
            <td>${o[i].releaseDate}</td>
            <td>${o[i].director}</td>
            <td>${o[i].boxOfficeInMillions}</td>
            <td>${o[i].runtimeInMinutes}</td>
            <td>${o[i].rating}</td>
        `

        tábla.appendChild(sor)
    }
})

//Hősök betöltése
fetch("api/heroes").then(r => r.json()).then(o => {
    var tálba = document.getElementById("heroes_table")
    console.log(o)

    for (var i = 0; i < o.length; i++) {
        var sor = document.createElement("tr")

        sor.innerHTML =
            `
            <td>${o[i].characterId}</td>
            <td>${o[i].name}</td>
            <td>${o[i].alias}</td>
            <td>${o[i].actor}</td>
            <td>${o[i].powers}</td>
            <td>${o[i].affiliation}</td>
        `

        tálba.appendChild(sor)

    }
})