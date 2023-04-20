<script>
  export let movie;
</script>

<div>
  <h2>{movie.title}</h2>
  <p>{movie.description}</p>
  <img src={movie.image} alt={movie.title}>
</div>