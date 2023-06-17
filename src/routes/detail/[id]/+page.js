/** @type {import('./$types').PageLoad} */

export async function load({fetch, params}) {
    const res = await fetch("http://localhost:5000/api/movies/" + params.id);
    const json = await res.json();

    return json;
}