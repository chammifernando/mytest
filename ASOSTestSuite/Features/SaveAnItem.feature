Feature: Use the website to save an item for later 
        So that I can save an item
        As a customer
        I want to be able to save items

Scenario: Save an item for later
        Given I have searched for yellows t shirts on the Australian store
        And I have some yellow t shirts displayed
        When I save an item for later
        Then I should see that item is saved