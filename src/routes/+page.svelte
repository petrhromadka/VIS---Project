<script>
    let movies = [
        {
            "id": 1,
            "title": "Film 1",
            "genre": "Žánr 1",
            "duration": 100,
            "director": "Režisér 1",
            "description": "Popis 1",
            "rating": 12,
            "thumbnail": "https://via.placeholder.com/200",
            "price": 180
        },
        {
            "id": 2,
            "title": "Film 2",
            "genre": "Žánr 2",
            "duration": 120,
            "director": "Režisér 2",
            "description": "Popis 2",
            "rating": 18,
            "thumbnail": "https://via.placeholder.com/200",
            "price": 200
        },
        // Přidejte další filmy podle stejné struktury
    ];

    let cart = [];

    function addMovieToCart(movie) {
        cart.push(movie);
    }
</script>

<svelte:head>
    <title>Filmy</title>
    <meta name="description" content="Přehled filmů" />
</svelte:head>

<section class="text-gray-600 body-font dark:text-gray-300">
    <div class="container px-5 py-24 mx-auto">
        <h1 class="text-3xl font-bold mb-6">Promítáme nyní u nás v kině</h1>
        <div class="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-4 gap-6">
            {#each movies as movie (movie.id)}
                <div class="flex flex-col overflow-hidden rounded shadow-lg dark:bg-gray-800">
                    <div class="flex-shrink-0">
                        <img class="h-48 w-full object-cover" src={movie.thumbnail} alt={movie.title}>
                    </div>
                    <div class="flex-1 bg-white dark:bg-gray-800 p-6 flex flex-col justify-between">
                        <div class="flex-1">
                            <p class="text-sm font-medium text-indigo-600 dark:text-indigo-400">
                                <a href="#" class="hover:underline">
                                    {movie.title}
                                </a>
                            </p>
                            <p class="text-gray-500 dark:text-gray-400">{movie.genre} • {movie.duration} min</p>
                            <p class="mt-2 text-gray-500 dark:text-gray-400">Režie: {movie.director}</p>
                            <p class="mt-2 text-gray-500 dark:text-gray-400">{movie.description}</p>
                            {#if movie.rating >= 18}
                                <div class="mt-2 flex items-center text-sm text-gray-500 dark:text-gray-400">
                                    <span class="inline-block bg-red-200 text-red-800 px-2 py-1 rounded-full text-xs">18+</span>
                                </div>
                            {/if}
                        </div>
                        <div class="mt-6">
                            <button onClick={() => addMovieToCart(movie)} class="bg-indigo-600 dark:bg-indigo-500 text-white px-2.5 py-1.5 rounded-md flex items-center">
                                <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke="currentColor" class="h-5 w-5 mr-1">
                                    <path stroke-linecap="round" stroke-linejoin="round" stroke-width="1.5" d="M2.25 3h1.386c.51 0 .955.343 1.087.835l.383 1.437M7.5 14.25a3 3 0 00-3 3h15.75m-12.75-3h11.218c1.121-2.3 2.1-4.684 2.924-7.138a60.114 60.114 0 00-16.536-1.84M7.5 14.25L5.106 5.272M6 20.25a.75.75 0 11-1.5 0 .75.75 0 011.5 0zm12.75 0a.75.75 0 11-1.5 0 .75.75 0 011.5 0z"></path>
                                </svg>
                                {movie.price} Kč
                            </button>
                        </div>
                    </div>
                </div>
            {/each}
        </div>
    </div>
</section>



