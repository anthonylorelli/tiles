<script lang="ts">
	export let name: string;

	import Avett from './TheAvettBrothers.svelte';
</script>

<main>
	<h1>Hello {name}!</h1>
	<p>This project by Anthony and Stephen is just getting started so there's really nothing interesting here yet.</p>

	<p>But fear not, we've got this awesome Avett Brothers component for you to look at, demonstrating a tiny bit of Svelte</p>

	<Avett />
</main>

<style>
	main
	{
		padding: 1em;
		max-width: 240px;
		margin: 0 auto;
	}

	h1
	{
		color: #ff3e00;
		text-transform: uppercase;
		font-size: 4em;
		font-weight: 100;
	}

	@media (min-width: 640px)
	{
		main
		{
			max-width: none;
		}
	}
</style>