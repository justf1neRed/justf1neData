const goButton = document.querySelector("button[name='searchButton']");

const title = document.querySelector("td[id='title']");
const year = document.querySelector("td[id='year']");
const actors = document.querySelector("td[id='actors']");
const director = document.querySelector("td[id='director']");
const genre = document.querySelector("td[id='genre']");
const lang = document.querySelector("td[id='lang']");

const poster = document.getElementById('poster');

function getMovie(url){

    const errorMsg = "Error loading information!";

    return new Promise((resolve, reject) =>{

        const getMovieRequest = new XMLHttpRequest();

        getMovieRequest.open("GET", url);

        getMovieRequest.onload = ()=>{

            if(getMovieRequest.status == 200){
                
                const currObject = JSON.parse(getMovieRequest.responseText);

                resolve(currObject);
            }
            else{

                reject(new Error(errorMsg));
            }
        };

        getMovieRequest.onerror = ()=>{
            reject(new Error(errorMsg));
        };

        getMovieRequest.send();
    });
}

goButton.addEventListener("click", ()=>{

    const search = document.getElementById('search').value;
    const movieUrl = `http://www.omdbapi.com/?t=${search}&apikey=365d77a0`;

    getMovie(movieUrl).then((video)=>{
        title.innerHTML = video.Title;
        year.innerHTML = video.Year;
        actors.innerHTML = video.Actors;
        director.innerHTML = video.Director;
        genre.innerHTML = video.Genre;
        lang.innerHTML = video.Language;
        poster.src = video.Poster;
    }).catch((error)=>{
        alert(error.message);
    });

    
});