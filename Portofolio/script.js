//zoom gambar
const closeZoomgmb=document.querySelector(".close-zoomgmb");
const zoomgmb=document.querySelector(".zoomgmb");
const zoomgmbImage=zoomgmb.querySelector("img")

    zoomgmb.addEventListener("click",function(){
        if(event.target!=zoomgmbImage){
            zoomgmb.classList.remove("show");
            zoomgmb.classList.add("hide");
        }
    })

    closeZoomgmb.addEventListener("click",function(){
        zoomgmb.classList.remove("show");
        zoomgmb.classList.add("hide");
    })

const gallery=document.querySelector(".kumpulan-foto");
const galleryFoto=gallery.querySelectorAll(".foto");

galleryFoto.forEach(function(element){
    element.querySelector(".fa-plus").addEventListener("click",function(){
        zoomgmb.classList.remove("hide");
        zoomgmb.classList.add("show");
        zoomgmbImage.src=element.querySelector("img").getAttribute("src")
    })
})

//header

window.onscroll=function(){
    const docScrollTop=document.documentElement.scrollTop;

    if(window.innerWidth>991){
        if(docScrollTop>100){
            document.querySelector("header").classList.add("fixed")
        }
        else{
            document.querySelector("header").classList.remove("fixed")
        }
    }
}

// navbar active

const navbar = document.querySelector(".navbar");
    a=navbar.querySelectorAll("a");

    a.forEach(function(element){
        element.addEventListener("click",function(){
            for(let i=0; i<a.length; i++)
            {
                a[i].classList.remove("active");
            }
            this.classList.add("active")
        })
    })
