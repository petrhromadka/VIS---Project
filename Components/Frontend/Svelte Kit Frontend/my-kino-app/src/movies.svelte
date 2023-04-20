
<script>
  import { onMount } from 'svelte';
  import { getMovies } from '../lib/api';
  import Movie from '../components/Movie.svelte';

  let movies = [];

  async function loadMovies() {
    movies = await getMovies();
  }

  onMount(() => {
    loadMovies();
  });
</script>

<h1>Seznam filmů</h1>

{#if movies.length === 0}
  <p>Žádné filmy nebyly nalezeny.</p>
{:else}
  <ul>
    {#each movies as movie}
      <li>
        <Movie {movie}/>
      </li>
    {/each}
  </ul>
{/if}
