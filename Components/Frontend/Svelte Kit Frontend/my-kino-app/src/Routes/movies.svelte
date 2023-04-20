<script>
  import { onMount } from 'svelte';
  import { getMovies } from '../api';
  import MovieList from '../components/MovieList.svelte';

  let movies = [];

  onMount(async () => {
    movies = await getMovies();
  });
</script>

<MovieList {movies} />
