<script>
  import { onMount } from 'svelte';
  import Header from './Header.svelte';
  import MovieList from './components/MovieList.svelte';
  import Footer from './Footer.svelte';
  import Corousel from "./Components/carousel.svelte";




  let movies = [];

  async function fetchMovies() {
    const response = await fetch('http://localhost:3000/movies');
    movies = await response.json();
  }

  onMount(fetchMovies);
</script>

<Header />

<main>
  <Corousel />
  <MovieList movies={movies} />
</main>

<Footer />
