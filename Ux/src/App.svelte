<script lang="ts">
	export let name: string;

	import Avett from './TheAvettBrothers.svelte';
	import Tile from './Tile.svelte';
</script>

<main>
	<h1>A Tile!</h1>

	<Tile topColor="gray" rightColor="lightBlue" bottomColor="red" leftColor="darkblue" />
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