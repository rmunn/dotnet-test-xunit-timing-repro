# Bug repro

Reproduction for a timing bug in `dotnet test`.

To reproduce:

- Clone this repo
- Run `time dotnet test`
- Note the time elapsed that dotnet test reports is the time taken to run the *second* test
- Confirm by looking at timestamps written to console

Whichever test runs first, its time elapsed will not be counted in the total. Try changing the time spent in Task.Delay calls, or adding a third test that sleeps a different number of seconds. The results are consistent: the total time reported is the actual time taken minus the time taken by the *first* test to run.
