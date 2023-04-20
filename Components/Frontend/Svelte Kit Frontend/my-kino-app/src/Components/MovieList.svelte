<script>
export let movies = [];
</script>

<h1>Movies:</h1>

{#if movies.length > 0}
<ul>
    {#each movies as movie}
    <li>{movie.title}</li>
    {/each}
</ul>
{:else}
<p>No movies available</p>
{/if}

<style> 

</style>
