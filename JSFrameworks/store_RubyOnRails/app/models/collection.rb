class Collection < ActiveRecord::Base
  has_many :jewels, dependent: :destroy
end
