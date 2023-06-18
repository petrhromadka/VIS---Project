<script>
	import { page } from '$app/stores';
	import { Navbar, NavBrand, NavLi, NavUl, NavHamburger } from 'flowbite-svelte';
	import logo from '$lib/images/logo.svg';
</script>

<header>
	<Navbar let:hidden let:toggle>
		<NavBrand href="/">
			<img src={logo} alt="CinemaPro" width="50" height="50" class="logo-footer" />
			<span class="self-center whitespace-nowrap text-xl font-semibold dark:text-white">
				CinemaPro
			</span>
		</NavBrand>
		<NavHamburger on:click={toggle} />
		<NavUl {hidden}>
			<NavLi
				href="/"
				active={$page.url.pathname === '/'}
				style="display: flex; align-items: center; gap: 0.5rem;"
				><svg
					xmlns="http://www.w3.org/2000/svg"
					fill="none"
					viewBox="0 0 24 24"
					stroke-width="1.5"
					stroke="currentColor"
					class="w-6 h-6"
				>
					<path
						stroke-linecap="round"
						stroke-linejoin="round"
						d="M2.25 12l8.954-8.955c.44-.439 1.152-.439 1.591 0L21.75 12M4.5 9.75v10.125c0 .621.504 1.125 1.125 1.125H9.75v-4.875c0-.621.504-1.125 1.125-1.125h2.25c.621 0 1.125.504 1.125 1.125V21h4.125c.621 0 1.125-.504 1.125-1.125V9.75M8.25 21h8.25"
					/>
				</svg>
				Home</NavLi
			>
		</NavUl>
	</Navbar>
</header>

<style>
	header {
		display: flex;
		justify-content: space-between;
	}

	.logo-footer {
		margin-top: 0.5rem;
		margin-right: 1rem;
		transform: scale(2.5);
	}
</style>
