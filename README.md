# KitCli Example: Filtering

This example demonstrates how to use KitCli to filter a list of items based on user input.

## How to Run
First run the following command to list all job roles:

```bash
/job-role
----------------------- 
| Job Role ID | Count |
----------------------- 
| 1           | 10    |
----------------------- 
| 2           | 10    |
----------------------- 
| 3           | 10    |
----------------------- 

Results: 3 rows
```
This command inserts a `CliListAggregator` into the artefacts for use in the next call.

Running the `/filter` command with the `--job-role-id` parameter filters the list to only include the specified job role ID:
```bash
/filter on --job-role-id 2
 ----------------------- 
| Job Role ID | Count |
----------------------- 
| 2           | 10    |
----------------------- 

Results: 1 rows
```
