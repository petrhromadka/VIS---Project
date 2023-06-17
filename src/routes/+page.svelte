<script>
	import { onMount } from 'svelte';
	import { Circle2 } from 'svelte-loading-spinners';

	let movies = [];
	let intervalId;

	onMount(async() =>{
		intervalId = setInterval(fetchMovies, 5000);
	});

	function fetchMovies() {
		console.log("Získávání filmů z databáze.");
		fetch('https://localhost:3333/api/movies') 
			.then((response) => response.json())
			.then((data) => {
				movies = data; 

				if (movies.length > 0) {
					clearInterval(intervalId); 
				}
			})
			.catch((error) => {
				console.log("Načtení filmů z databáze selhalo!");
			});
	}
</script>

<svelte:head>
	<title>Filmy</title>
	<meta name="description" content="Přehled filmů" />
</svelte:head>

<section class="text-gray-600 body-font dark:text-gray-300">
	<div class="container px-5 py-24 mx-auto">
		{#if !movies.length == 0}
			<h1 class="text-3xl font-bold mb-6">Promítáme nyní u nás v kině</h1>
			<div class="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-3 gap-6">
				{#each movies as movie (movie.id)}
					<div class="flex flex-col overflow-hidden rounded shadow-lg dark:bg-gray-800">
						<div class="flex-shrink-0">
							<img class="h-48 w-full object-cover" src={movie.thumbnail} alt={movie.title} />
						</div>
						<div class="flex-1 bg-white dark:bg-gray-800 p-6 flex flex-col justify-between">
							<div class="flex-1">
								<p class="text-sm font-medium text-indigo-600 dark:text-indigo-400">
									<a
										href="./detail/{movie.id}"
										data-sveltekit-preload-data="tap"
										class="hover:underline"
									>
										{movie.title}
									</a>
								</p>
								<p class="text-gray-500 dark:text-gray-400">{movie.genre} • {movie.duration} min</p>
								<p class="mt-2 text-gray-500 dark:text-gray-400">Režie: {movie.director}</p>
							</div>
						</div>
					</div>
				{/each}
			</div>
		{:else}
			<div class="absolute top-1/2 left-1/2 -translate-1/2">
				<Circle2 size="60" color="#FF3E00" unit="px" duration="1s" />
			</div>
		{/if}
	</div>
</section>
