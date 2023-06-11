<script>
	import { page } from '$app/stores';
	import { DarkMode } from 'flowbite-svelte';
	import { goto } from '$app/navigation';
	import {
	  Navbar,
	  NavBrand,
	  NavLi,
	  NavUl,
	  NavHamburger,
	} from 'flowbite-svelte';
	import logo from '$lib/images/logo.svg';
	
  </script>
  
  <header>
	
  
	<Navbar let:hidden let:toggle>
	  <NavBrand href="/">
		<img src={logo} alt="CinemaPro" width="50" height="50" class="logo-footer"/>
		<span class="self-center whitespace-nowrap text-xl font-semibold dark:text-white">
		  CinemaPro
		</span>
	  </NavBrand>
	  <NavHamburger on:click={toggle} />
	  <NavUl {hidden} class="flex">
		<NavLi href="/" active={$page.url.pathname === '/'}>Home</NavLi>
		<NavLi href="/cart" active={$page.url.pathname === '/cart'}>Rezervace</NavLi>
		<NavLi href="/contact" active={$page.url.pathname === '/contact'}>Contact</NavLi>
	  </NavUl> 
	  <DarkMode />
	</Navbar>
  </header>
  
  <style>
	header {
	  display: flex;
	  justify-content: space-between;
	}

	.logo-footer{
    margin-top: 0.5rem;
    margin-right: 1rem;
    transform: scale(2.5);
   }
	</style>  