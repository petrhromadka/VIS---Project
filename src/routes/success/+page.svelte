<script>
    import { onMount } from 'svelte';
    import success from '$lib/images/success.svg';

    onMount(() => {
        setTimeout(() => {
            window.location.href = '/'; 
        }, 15000); //přesměrování na úvodní stránku. 
    });
</script>

<div class="container mx-auto py-12 px-4">
    <h1 class="text-3xl font-bold mb-6 text-gray-900 dark:text-white">Děkujeme za rezervaci!</h1>
    <p class="text-lg mb-4 text-gray-900 dark:text-white">Na Vaši e-mailovou adresu bylo odesláno potvrzení rezervace. Lístky jsou za zakoupeny.</p>
    <p class="text-lg text-gray-900 dark:text-white">Budete přesměrováni zpět na úvodní stránku</p>
</div>
<img src="{success}" alt="Dokončení objednávky" class="success">

<style>

    .success{
        width: 30rem;
    }
</style>
