<!-- src/routes/movie/[id].svelte -->
<script>
import { onMount } from 'svelte';
import { useParams } from '@sveltejs/kit';
import { getMovie, createSession } from '../../lib/api';
import Movie from '../../components/Movie.svelte';

let movie;
let time = '';
let availableSeats = '';

const handleSubmit = async (event) => {
    event.preventDefault();
    await createSession(movie.id, { time, availableSeats });
    // přesměrujte uživatele na stránku s detaily filmu
};

const params = useParams();
const id = params.id;

  async function loadMovie() {
    movie = await getMovie(id);
  }

  onMount(() => {
    loadMovie();
  });
</script>

<h1>{movie.title}</h1>

<Movie {movie}/>

<form on:submit={handleSubmit}>
  <label>
    Čas:
    <input type="text" bind:value={time}>
  </label>
  <label>
    Dostupná místa:
    <input type="text" bind:value={availableSeats}>
  </label>
  <button type="submit">Vytvořit sezení</button>
</form>
