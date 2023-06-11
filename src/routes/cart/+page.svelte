<script>
    import { Alert } from 'flowbite-svelte';

    let customerName = '';
    let phoneNumber = '';
    let email = '';
    let price = 0;

    let movie = {
        title: 'Název filmu',
        price: 200
    };

    let seat = {
        row: 'Řada A',
        number: 'Sedadlo 1'
    };

    let showAlert = false;

    function submitForm() {
        if (customerName === '' || email === '') {
            showAlert = true;
        } else {
            window.location.href = '/success';
        }
    }
</script>

<div class="bg-white dark:bg-gray-800">
    <div class="container mx-auto py-12 px-4">
        <h1 class="text-3xl font-bold mb-6 text-gray-900 dark:text-white">Rezervace lístků do kina</h1>

        <!-- Alert komponenta pro nevyplněná povinná pole -->
        {#if showAlert}
            <Alert color="red">
                <svg slot="icon" aria-hidden="true" class="w-5 h-5" fill="currentColor" viewBox="0 0 20 20" xmlns="http://www.w3.org/2000/svg">
                    <path fill-rule="evenodd" d="M18 10a8 8 0 11-16 0 8 8 0 0116 0zm-7-4a1 1 0 11-2 0 1 1 0 012 0zM9 9a1 1 0 000 2v3a1 1 0 001 1h1a1 1 0 100-2v-3a1 1 0 00-1-1H9z" clip-rule="evenodd"></path>
                </svg>
                <span class="font-medium">Prosím vyplňte povinná pole.</span>
            </Alert>
        {/if}

        <div class="flex flex-col md:flex-row gap-4">
            <div class="md:w-1/2">
                <div class="mb-4">
                    <label for="customerName" class="text-base text-gray-600 dark:text-gray-300">Vaše jméno a příjmení*:</label>
                    <input type="text" id="customerName" bind:value={customerName} required class="mt-1 p-2 w-full border rounded-md text-gray-900 dark:text-white dark:bg-gray-700">
                </div>
                <div class="mb-4">
                    <label for="phoneNumber" class="text-base text-gray-600 dark:text-gray-300">Zadejte Vaše telefonní číslo:</label>
                    <input type="tel" id="phoneNumber" bind:value={phoneNumber} class="mt-1 p-2 w-full border rounded-md text-gray-900 dark:text-white dark:bg-gray-700">
                </div>
                <div class="mb-4">
                    <label for="email" class="text-base text-gray-600 dark:text-gray-300">Zadejte svůj email*:</label>
                    <input type="email" id="email" bind:value={email} required class="mt-1 p-2 w-full border rounded-md text-gray-900 dark:text-white dark:bg-gray-700">
                </div>
            </div>

            <div class="md:w-1/2">
                <div class="bg-gray-200 dark:bg-gray-700 p-4 rounded-md">
                    <p class="text-base font-bold mb-2 text-gray-900 dark:text-white">Film:</p>
                    <p class="text-lg text-gray-700 dark:text-white mb-4">{movie.title} - {movie.price} Kč</p>
                    <p class="text-base font-bold mb-2 text-gray-900 dark:text-white">Místo rezervace:</p>
                    <p class="text-lg text-gray-700 dark:text-white">{seat.row} - {seat.number}</p>
                </div>
            </div>
        </div>

        <div class="flex justify-between items-center mt-8">
            <div>
                <p class="text-base font-bold text-gray-900 dark:text-white">Způsob doručení:</p>
                <div class="mt-2">
                    <label class="inline-flex items-center text-gray-900 dark:text-white">
                        <input type="radio" name="deliveryMethod" value="MailTicket" checked class="text-indigo-600 bg-white border-gray-300 dark:text-indigo-400 dark:bg-gray-800 dark:border-gray-600 focus:ring-indigo-500">
                        <span class="ml-2">MailTicket - Vstupenka emailem pro vytištění</span>
                    </label>
                </div>
            </div>
            <div class="flex items-center space-x-4">
                <p class="text-xl font-bold text-gray-900 dark:text-white">Celková cena:</p>
                <p class="text-xl font-bold text-gray-900 dark:text-white">{price} Kč</p>
            </div>
        </div>

        <div class="mt-8">
            <button class="bg-indigo-600 text-white px-4 py-2 rounded-md" on:click={submitForm}>Odeslat rezervaci</button>
        </div>
    </div>
</div>
