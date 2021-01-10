
const videoUrl = "https://www.googleapis.com/youtube/v3/videos?id=9bZkp7q19f0&key=AIzaSyC_rBtiAkMF93Ck1VXNSedj4Fivs8C7d28&part=statistics";
var numberOfViews;
var result = document.querySelector("div[name='resultTab']");

function getVideo(url){

    const errorMsg = "Error loading the information!";

    return new Promise((resolve, reject)=>{

        const getVideoRequest = new XMLHttpRequest();

        getVideoRequest.open("GET", url);

        getVideoRequest.onload = ()=>{

            if(getVideoRequest.status == 200){

                const videoObject = JSON.parse(getVideoRequest.responseText);

                resolve(videoObject);
            }
            else{
                reject(new Error(errorMsg));
            }
        };

        getVideoRequest.onerror = ()=>{
            reject(new Error(errorMsg));
        };
        getVideoRequest.send();
    });
}

getVideo(videoUrl).then((video)=>{
    result.innerHTML += (video.items[0].statistics.viewCount);
}).catch((error)=>{
    alert(error.message);
});