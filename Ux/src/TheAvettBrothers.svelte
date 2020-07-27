<script lang="ts">
    interface IMusician
    {
        name: string;
        instrument: string;
    }

    const theAvettBrothers: IMusician[] =
    [
        { name: 'Scott Avett', instrument: 'banjo' },
        { name: 'Seth Avett', instrument: 'guitar' },
        { name: 'Bob Crawford', instrument: 'bass' },
        { name: 'Joe Kwon', instrument: 'cello' },
        { name: 'Mike Marsh', instrument: 'drums' },
        { name: 'Tania Elizabeth', instrument: 'violin' }
    ];
</script>

<h1>The Avett Brothers!</h1>

<ul>
    { #each theAvettBrothers as musician }
        <li><b>{ musician.name } - lord of the { musician.instrument }</b></li>
    { /each }
</ul>