export async function load({ fetch, params}){
    const res = await fetch("https://localhost:3333/api/movies/" + params.id);
    const moviesJson = await res.json();

    return moviesJson;
}