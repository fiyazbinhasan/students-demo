fetch('https://localhost:44347/api/values')
  .then(response => response.json())
  .then(json => myResponse(json));


function myResponse(response){
    let out = "";
    for(let i = 0; i < response.length; i++)
    {
        out += `<p>${response[i].body}</p>`;
    }
    
    document.getElementById('posts').innerHTML = out;
}